using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace ConnexionDPI
{
   public class Model
    {



        public MySqlDataAdapter mySqlDataAdapter;
        public MySqlCommandBuilder mySqlCommandBuilder;
        public DataTable dataTable;
        public BindingSource bindingSource;


        //-----------------------------------    DATA BINDING   -------------------
        public void ExecuteNonQuery(string nonQuery)
        {
            new MySqlCommand(nonQuery, Tools.mySqlConnection).ExecuteNonQuery();
        }

        public void Bind(DataGridView dataGridView, BindingNavigator bindingNavigator, string sqlQuery)
        {

            mySqlDataAdapter = new MySqlDataAdapter(sqlQuery, Tools.mySqlConnection);
            mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

            mySqlDataAdapter.UpdateCommand = mySqlCommandBuilder.GetUpdateCommand();
            mySqlDataAdapter.DeleteCommand = mySqlCommandBuilder.GetDeleteCommand();
            mySqlDataAdapter.InsertCommand = mySqlCommandBuilder.GetInsertCommand();

            dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            dataGridView.DataSource = bindingSource;
            bindingNavigator.BindingSource = bindingSource;

        }

        //-------------cette surdefinition permet d'avoir le meme bindingSource pour dataGridView,bindingNavigator, dataTable---
        public void Bind(DataGridView dataGridView, BindingNavigator bindingNavigator, DataTable dt, BindingSource bs, string sqlQuery)
        {

            mySqlDataAdapter = new MySqlDataAdapter(sqlQuery, Tools.mySqlConnection);
            mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

            mySqlDataAdapter.UpdateCommand = mySqlCommandBuilder.GetUpdateCommand();
            mySqlDataAdapter.DeleteCommand = mySqlCommandBuilder.GetDeleteCommand();
            mySqlDataAdapter.InsertCommand = mySqlCommandBuilder.GetInsertCommand();

            dataTable = dt;// new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            bindingSource = bs;// new BindingSource();
            //bindingSource.DataSource = dataTable;

            dataGridView.DataSource = bindingSource;
            bindingNavigator.BindingSource = bindingSource;

        }


        public void Bind(string sqlQuery, DataTable dataTable1)
        {
            BindingSource bindingSource = new BindingSource();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sqlQuery, Tools.mySqlConnection); ;
            Bind(sqlQuery, dataTable1, mySqlDataAdapter, bindingSource);
        }

        //-------------cette surdefinition permet d'avoir le meme bindingSource pour dataGridView,bindingNavigator, dataTable---
        public void Bind(string sqlQuery, DataTable dt, BindingSource bs)
        {

            mySqlDataAdapter = new MySqlDataAdapter(sqlQuery, Tools.mySqlConnection);
            mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

            mySqlDataAdapter.UpdateCommand = mySqlCommandBuilder.GetUpdateCommand();
            mySqlDataAdapter.DeleteCommand = mySqlCommandBuilder.GetDeleteCommand();
            mySqlDataAdapter.InsertCommand = mySqlCommandBuilder.GetInsertCommand();

            dataTable = dt;// new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            bindingSource = bs;// new BindingSource();
            //bindingSource.DataSource = dataTable;


        }

        public void Bind(string sqlQuery, DataTable dataTable1, MySqlDataAdapter mySqlDataAdapter, BindingSource bindingSource)
        {

            //mySqlDataAdapter = new MySqlDataAdapter(sqlQuery, Tools.mySqlConnection);
            MySqlCommandBuilder mySqlCommandBuilder1 = new MySqlCommandBuilder(mySqlDataAdapter);

            mySqlDataAdapter.UpdateCommand = mySqlCommandBuilder1.GetUpdateCommand();
            mySqlDataAdapter.DeleteCommand = mySqlCommandBuilder1.GetDeleteCommand();
            mySqlDataAdapter.InsertCommand = mySqlCommandBuilder1.GetInsertCommand();

            mySqlDataAdapter.Fill(dataTable1);

            //bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable1;

        }

        public void Save()
        {
            bindingSource.EndEdit();
            mySqlDataAdapter.Update(dataTable);

        }


    }
}
