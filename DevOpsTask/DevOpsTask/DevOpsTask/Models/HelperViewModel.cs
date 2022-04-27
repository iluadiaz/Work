using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DevOpsTask.DAL.Abstract;
using DevOpsTask.DAL.Concrete;

namespace DevOpsTask.Models
{
    public class HelperViewModel
    {
        List<AppointedApp>          AppointedPeople = null;

        List<BoardMembersFulldatum> MemberData      = null;

        List<PersonApplication>     Applicants      = null;

    }

}
