namespace Sample_SameName_Check
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_DataSet_Click(object sender, EventArgs e)
        {
            //DataSet Create
            System.Data.DataSet PeopleList = new();
            PeopleList.Tables.Add("PeopleInfo");
            PeopleList.Tables["PeopleInfo"].Columns.Add("Id");
            PeopleList.Tables["PeopleInfo"].Columns.Add("Name");
            PeopleList.Tables["PeopleInfo"].Columns.Add("Age");
            PeopleList.Tables["PeopleInfo"].Columns.Add("Sex");


            //Input Data
            for (int i = 0; i < 10; i++)
            {
                PeopleList.Tables["PeopleInfo"].Rows.Add(i + 1, "", new Random().Next() % 100, new Random().Next() % 2 == 1 ? "M" : "F");
            }

            //Data Binding
            dgvPeopleList.DataSource = PeopleList;
            dgvPeopleList.DataMember = PeopleList.Tables["PeopleInfo"].TableName;
        }

        private void btn_NameCheck_Click(object sender, EventArgs e)
        {
            SameName_Check NameCheck = new ();
            NameCheck.SetColor_SameName(ref dgvPeopleList, "Name");
        }
    }
}