using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Demo01OOP
{
    internal struct PhoneBook
    {
        string[] names;
        long[] Numbers;

        public PhoneBook(int size)
        {
            names = new string[size];
            Numbers = new long[size];
        }

        public void AddPerson(string name, long number, int index)
        {
            names[index] = name;
            Numbers[index] = number;
        }

        public long GetNumber(string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                    return Numbers[i];
            }
            return -1;

        }

        public void UpdateNumber(string name, long NewNumber)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                    Numbers[i] = NewNumber;
            }

        }

        public string GetName(long number)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (Numbers[i] == number)
                    return names[i];
            }
            return "";

        }
        public void UpdateName(long number, string Newname)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (Numbers[i] == number)
                    names[i] = Newname;
            }

        }

        public long this [string name] 
        {
            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                        return Numbers[i];
                }
                return -1;

            }
            set
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                        Numbers[i] = value;
                }


            }
            

        }

        public string this[long number]
        {
            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (Numbers[i] == number)
                        return names[i];
                }
                return "";

            }
            set
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (Numbers[i] == number)
                        names[i] = value;
                }

            }

        }
       }
    }
