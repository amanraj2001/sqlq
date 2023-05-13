using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Inventoryextratask
{
    internal class Program
    {

        //class product {


        //    //public void createtable()
        //    //{
        //    //    SqlConnection con = null;
        //    //    try
        //    //    {
        //    //        SqlConnection con = new SqlConnection()

        //    //    }
        //    //}


        //}

        public void create()
        {

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SqlConnection con = new SqlConnection("data source=PC0759\\MSSQL2019; database=new; integrated security=SSPI");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from product",con);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {

                Console.WriteLine(sdr["productid"]);
            }

        }

    }
}