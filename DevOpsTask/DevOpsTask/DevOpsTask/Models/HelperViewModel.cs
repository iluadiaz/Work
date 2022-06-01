using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DevOpsTask.DAL.Abstract;
using DevOpsTask.DAL.Concrete;
using System.Xml;
using System.Xml.Linq;

namespace DevOpsTask.Models
{
    public class HelperViewModel
    {
        public IEnumerable<AppointedApp>                AppointedApplications       = null;

        public IEnumerable<BoardMembersFulldatum>       BoardMembersFulldatums      = null;
         
        public IEnumerable<PersonApplications>          PersonApplications          = null;
      
        public IEnumerable<PersonApplicationsDetail>    PersonApplicationsDetails   = null;

        public IEnumerable<MBoardsandCommissions>       MBoardsandCommissions       = null;

        public IEnumerable<Person>                      Person                      = null;

        public IEnumerable<SubmittedApplication>        SubmittedApplications       = null;

        public IEnumerable<RequirementsModel>           Requirements                = null;

        public string                                   Board                       = null;

        public string                                   PersonId                    = null;
        public List<string> ParseQuestionsXML(string xml)
        {
            var doc = XDocument.Parse(xml);

            var stuff = doc.Descendants("QuestionText").ToList();

            List<string> stuffButAString = new List<string>();

            foreach (var x in stuff)
            {
                stuffButAString.Add(x.Value);
            }

            return stuffButAString;
        }
        public List<string> ParseAnswersXML(string xml)
        {
            var doc = XDocument.Parse(xml);
            
            var stuff = doc.Descendants("Answer_Text").ToList();

            List<string> stuffButAString = new List<string>();

            foreach (var x in stuff)
            {
                stuffButAString.Add(x.Value);
            }

            return stuffButAString;
        }

        public List<RequirementsModel> GetData(List<Person> people, List<MBoardsandCommissions> boards,
            List<PersonApplications> applications, List<SubmittedApplication> submittedApplications)
        {
            List<RequirementsModel> model = new List<RequirementsModel>();
            foreach (var x in applications)
            {
                foreach(var y in people)
                {
                    if(x.PersonKey == y.PersonKey)
                    {
                        foreach(var z in boards)
                        if(x.BoardCommissionKey == z.BoardCommissionKey)
                            {
                                RequirementsModel addMe = new RequirementsModel();
                                addMe.FirstName = y.FirstName;
                                addMe.LastName = y.LastName;
                                addMe.ApplicationDate = x.ApplicationDate.ToString("MMMM dd, yyyy");
                                addMe.Appointed = x.Appointed;
                                addMe.Address = y.StreetAddress + " "+ y.City + " " + y.ZipCode;
                                addMe.Phone = y.CellPhone;
                                addMe.Email = y.EmailAddress;
                                addMe.Questions = ParseQuestionsXML(x.SupplementalAnswers);
                                addMe.Answers = ParseAnswersXML(x.SupplementalAnswers);
                                addMe.BoardSeat = z.BoardOrCommissionName;
                                addMe.PersonId = y.PersonKey.ToString();
                                model.Add(addMe);
                            }
                    }
                }
            }
            return model;
        }
    }
}
