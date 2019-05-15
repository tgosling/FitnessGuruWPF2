using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FitnessGuruWPF2
{
    public class Member
    {
        public string usrName { get; set; }
        public string usrPsswrd { get; set; }
        public string usrFName { get; set; }
        public string usrLName { get; set; }
        public string usrDOB { get; set; }
        public string usrAddr { get; set; }
        public string usrCity { get; set; }
        public string usrProv { get; set; }
        public string usrCmnts { get; set; }
        public string usrTrnr { get; set; }
        public string usrProgLvl { get; set; }
        public bool billMntly { get; set; }
        public bool dircDeb { get; set; }
        public bool annMemCon { get; set; }
        public string usrCrdtCrd { get; set; }
        public string usrCrdtExpMnth { get; set; }
        public string usrCrdtExpYr { get; set; }

        //To-string to serialize user info into JSON object
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        //Member Constructor when creating a new member
        public Member(string usrN, string passW)
        {
            this.usrName = usrN;
            this.usrPsswrd = passW;
        }
    }

}


