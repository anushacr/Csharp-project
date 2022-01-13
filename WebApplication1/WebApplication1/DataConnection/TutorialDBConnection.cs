using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.DataConnection
{
    public class TutorialDBConnection
    {
        string sqlConnectionStr = "Data Source=DESKTOP-U645CGB;Initial Catalog=TutorialDB;Integrated Security=True";
        public string InsertTutorial(TutorialModel tutorialModelObj)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("insert into Tutorial values(" + tutorialModelObj.TutorialId + ",'" + tutorialModelObj.TutorialName + "','" + tutorialModelObj.TutorialDesc + "'," + tutorialModelObj.Published + ")", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return "Tutorial details saved successfully";
        }
        public void UpdateTutorial(TutorialModel tutorialModelObj)
        {

        }
        public void DeleteTutorialById(int tutorialId)
        {

        }
        public DataTable SelectTutorial()
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("select * from Tutorial", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dt;
        }
        public void EditTutorialById(int tutorialId)
        {

        }
    }
}