using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Sample_SameName_Check
{
    internal class SameName_Check
    {
        /// <summary>
        /// 동명이인 체크 로직
        /// </summary>
        /// <param name="_Dgv"></param>
        /// <param name="_ColName"></param>
        public void SetColor_SameName(ref DataGridView _Dgv, string _ColName)
        {
            Dictionary<string, int> NameDictionary = new();

            try
            {
                foreach (DataGridViewRow rows in _Dgv.Rows)
                {
                    if (!String.IsNullOrEmpty(Convert.ToString(rows.Cells[_ColName].Value)))
                    {
                        string Name = Regex.Replace(rows.Cells[_ColName].Value.ToString(), @"[^a-zA-z가-힣]+", "");

                        if (NameDictionary.ContainsKey(Name))
                            NameDictionary[Name] += 1;
                        else
                            NameDictionary.Add(Name, 1);
                    }
                }

                var SameNameList = from SameName in NameDictionary
                                   where SameName.Value > 1
                                   select SameName.Key;

                foreach (DataGridViewRow rows in _Dgv.Rows)
                {
                    if (!String.IsNullOrEmpty(Convert.ToString(rows.Cells[_ColName].Value)))
                    {
                        string SameName = Regex.Replace(rows.Cells[_ColName].Value.ToString(), @"[^a-zA-z가-힣]+", "");

                        if (SameNameList.Contains(SameName))
                            rows.Cells[_ColName].Style.BackColor = Color.Violet;
                    }
                }
            }
            catch
            {

            }
        }
    }
}
