string bitmmap = "";
            bitmmap = bitmap.Text;
            string Nm = "", Ei = "", Desg = "", Es = "", On = "", Gndr = "";
            string value = bitmmap;
            Nm = name.Text; Ei = emp_id.Text; Desg = desgntion.Text; Es = Emp_Salry.SelectedItem.Text; On = OrgName.Text; Gndr = RadioButtonList1.SelectedItem.Value;
            string[] VALUSS = new string[6] { Nm,Ei,Desg,Es,On,Gndr };
            string q = "", w = "", r = "",t="",h="",x="";     
            for (int i = 0; i < value.Length; i++)
            {
                char abc=(value[i]);
                string a=abc.ToString();
                if (a != "0")
                {
                    if (i == 0)
                    {
                        q = VALUSS[i];
                    }
                    if (i == 1)
                    {
                        w = VALUSS[i];
                    }
                    if (i == 2)
                    {
                        r = VALUSS[i];
                    }
                    if (i == 3)
                    {
                        t = VALUSS[i];
                    }
                    if (i == 4)
                    {
                        h = VALUSS[i];
                    }
                    if (i == 5)
                    {
                        x = VALUSS[i];
                    }  
                }              
            }
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            SqlCommand cmd = new SqlCommand("INSERT into TbleRecrd (name,empid,desgntion,Orgname,Emp_Sal,RadioButtonList1) values (@name,@emp_id,@desgntion,@Emp_Salry,@OrgName,@RadioButtonList1)", con);
            cmd.Parameters.AddWithValue("@name", q);
            cmd.Parameters.AddWithValue("@emp_id", w);
            cmd.Parameters.AddWithValue("@desgntion", r);
            cmd.Parameters.AddWithValue("@Emp_Salry", t);
            cmd.Parameters.AddWithValue("@OrgName", h);
            cmd.Parameters.AddWithValue("@RadioButtonList1", x);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("grid.aspx");
        }
