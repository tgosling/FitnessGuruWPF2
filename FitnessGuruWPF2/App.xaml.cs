﻿using System;
using System.Collections.Generic;
using System.Windows;
using System.IO;
using Newtonsoft.Json;

namespace FitnessGuruWPF2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public List<Member> memberList { get; set; }
        public int loggedInUser { get; set; }
        public MainWindow mainWindow;
        public MemberInfo memberInfo;


        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            memberList = new List<Member>();
            mainWindow = new MainWindow();
            memberInfo = new MemberInfo();
            loadUsers();
        }

        //Registers user when a new member is created
        public bool registerUser(string usrN, string pssW)
        {
            memberList.Add(new Member(usrN, pssW));
            loggedInUser = memberList.Count - 1;
            return true;
        }

        //Checks if the member exists and that their credentials are 
        public bool checkLogin(string usrN, string pssW)
        {
            int count = 0;

            foreach (Member hold in memberList)
            {
                if (hold.usrName == usrN && hold.usrPsswrd == pssW)

                {
                    loggedInUser = count;
                    return true;
                }
                count++;
            }
            return false;
        }

        //save user to Json list of members
        public void saveUsers()
        {
            string fileStr = "[\n";

            foreach (Member hold in memberList)
            {
                fileStr += hold.ToString() + ",\n";
            }
            //remove the trailing comma
            fileStr.Remove(fileStr.Length - 1);
            fileStr += "]";
            File.WriteAllText("users.json", fileStr);
        }


        //Load users from Json obj for login credential checking
        public void loadUsers()
        {
            try
            {
       if (File.Exists("users.json"))

                {
                    string jsonStr = File.ReadAllText("users.json");
                    memberList = JsonConvert.DeserializeObject<List<Member>>(jsonStr);
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public static new App Current
        {
            get { return Application.Current as App; }
        }
    }
}
