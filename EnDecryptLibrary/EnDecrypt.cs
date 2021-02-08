using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnDecryptLibrary
{
    
    public class EnDecrypt
    {
        public static string Encrypt(string input, string key, string secondKey)
        {
            List<ClassData> listData = ResetData();
            int dataCount = listData.Count;
            int manipulator = 0;
            bool process = true;
            string result = "";
            string text = input;
            string output = "";
            int secondaryKey = GenerateSecondaryKey(secondKey);
            
            UseKey(listData, key, ref result);
            if (result != "Success")
            {
                return result;
            }

            while (process) // Matching the index with manipulators to create encrypted text
            {
                try
                {
                    if (text.Length > 0)
                    {
                        manipulator = (manipulator + secondaryKey) % dataCount;
                        for (int i = 0; i < dataCount; i++)
                        {
                            if (text.Substring(0, 1) == listData[i].Cha)
                            {
                                for (int j = 0; j < dataCount; j++)
                                {
                                    if (int.Parse(listData[i].Shuf) == j)
                                    {
                                        output += listData[(j + manipulator) % dataCount].Cha;
                                        text = text.Remove(0, 1);
                                        break;
                                    }
                                }
                                break;
                            }
                        }
                    }
                    else
                    {
                        process = false;
                        text = "";
                    }
                }
                catch (Exception)
                {
                    return "Encryption failed due to incompetence of encrypted text input. \nPay attention to each characters, including upper case, lower case, spaces even tabs and enters.";
                }
            }
            return output;
        }
        public static string Decrypt(string input, string key, string secondKey)
        {
            List<ClassData> listData = ResetData();
            int dataCount = listData.Count;
            string result = "";
            int manipulator = 0;
            bool process = true;
            string text = input;
            string output = "";
            int secondaryKey = GenerateSecondaryKey(secondKey);

            UseKey(listData, key, ref result);
            if (result != "Success") return result;
            while (process)
            {
                if (text.Length > 0)
                {
                    manipulator = (manipulator + secondaryKey) % dataCount;
                    for (int i = 0; i < dataCount; i++)
                    {
                        if (text.Substring(0, 1) == listData[(i + manipulator) % dataCount].Cha)
                        {
                            for (int j = 0; j < dataCount; j++)
                            {
                                if (int.Parse(listData[j].Shuf) == i)
                                {
                                    output += listData[j].Cha;
                                    text = text.Remove(0, 1);
                                    break;
                                }
                            }
                            break;
                        }
                    }
                }
                else
                {
                    process = false;
                    text = "";
                }
            }
            return output;
        }

        private static void InputData(string ch, int id, string sh, List<ClassData> listData)
        {
            ClassData data = new ClassData(ch, id, sh);
            listData.Add(data);
        }
        private static void GenerateCode(int ind, List<ClassData> listData, Random generator)
        {
            listData[ind].Shuf = generator.Next(0, listData.Count).ToString();
            bool valid = true;
            for (int i = 0; i < listData.Count; i++)
            {
                if (listData[i].Shuf == listData[ind].Shuf && i != ind)
                {
                    valid = false;
                    listData[ind].Shuf = "";
                    break;
                }
            }
            if (valid == false)
            {
                GenerateCode(ind, listData, generator);
            }
        }
        private static void DegenerateCode(List<ClassData> listData, ref string text, ref string result)
        {
            for (int p = listData.Count-1; p >= 0; p--)
            {
                try
                {
                    for (int i = 0; i < listData.Count; i++)
                    {
                        if (text.Substring(text.Length - 1, 1) == listData[i].Cha)
                        {
                            listData[p].Shuf = i.ToString();
                            text = text.Remove(text.Length - 1, 1);
                            break;
                        }
                    }
                }
                catch (Exception)
                {
                    result = "Decryption failed due to incompetence of encrypted text input. \nPay attention to each characters, including upper case, lower case, spaces even tabs and enters.";
                    return;
                }
            }
            result = "Success";
        }

        private static void UseKey(List<ClassData> listData, string keyInput, ref string result)
        {
            string input = keyInput;
            if (input.Length != listData.Count)
            {
                result = "Failed to synchronize Primary Key with EnDecrypt data system. Please make sure you've entered the coorect key.";
            }
            else
            {
                for (int i = 0; i < listData.Count; i++)
                {
                    for (int j = 0; j < listData.Count; j++)
                    {
                        if (listData[j].Cha == input.Substring(0, 1))
                        {
                            listData[i].Shuf = listData[j].Id.ToString();
                            input = input.Remove(0, 1);
                            break;
                        }
                    }
                }
                result = "Success";
            }
        }

        public static string GenerateKey()
        {
            string res = "";
            List<ClassData> listData = ResetData();
            Random rand = new Random();
            for (int i = 0; i < listData.Count; i++)
            {
                GenerateCode(i, listData, rand);
            }
            foreach (ClassData data in listData)
            {
                res = res + listData[int.Parse(data.Shuf)].Cha;
            }
            return res;
        }

        public static int GenerateSecondaryKey(string input)
        {
            List<ClassData> listData = ResetData();
            int res = 0;
            string text = input;
            while (text.Length > 0)
            {
                for (int i = 0; i < listData.Count; i++)
                {
                    if (text.Substring(0, 1) == listData[i].Cha)
                    {
                        res = res + listData[i].Id;
                        text = text.Remove(0, 1);
                        break;
                    }
                }
            }
            return res;
        }
        private static List<ClassData> ResetData()
        {
            List<ClassData> listInputData = new List<ClassData>();
            InputData(" ", 0, "", listInputData);
            InputData("!", 1, "", listInputData);
            InputData("#", 2, "", listInputData);
            InputData("$", 3, "", listInputData);
            InputData("%", 4, "", listInputData);
            InputData("&", 5, "", listInputData);
            InputData("(", 6, "", listInputData);
            InputData(")", 7, "", listInputData);
            InputData("*", 8, "", listInputData);
            InputData("+", 9, "", listInputData);
            InputData(",", 10, "", listInputData);
            InputData("-", 11, "", listInputData);
            InputData(".", 12, "", listInputData);
            InputData("/", 13, "", listInputData);
            InputData("0", 14, "", listInputData);
            InputData("1", 15, "", listInputData);
            InputData("2", 16, "", listInputData);
            InputData("3", 17, "", listInputData);
            InputData("4", 18, "", listInputData);
            InputData("5", 19, "", listInputData);
            InputData("6", 20, "", listInputData);
            InputData("7", 21, "", listInputData);
            InputData("8", 22, "", listInputData);
            InputData("9", 23, "", listInputData);
            InputData(":", 24, "", listInputData);
            InputData(";", 25, "", listInputData);
            InputData("<", 26, "", listInputData);
            InputData("=", 27, "", listInputData);
            InputData(">", 28, "", listInputData);
            InputData("?", 29, "", listInputData);
            InputData("@", 30, "", listInputData);
            InputData("A", 31, "", listInputData);
            InputData("B", 32, "", listInputData);
            InputData("C", 33, "", listInputData);
            InputData("D", 34, "", listInputData);
            InputData("E", 35, "", listInputData);
            InputData("F", 36, "", listInputData);
            InputData("G", 37, "", listInputData);
            InputData("H", 38, "", listInputData);
            InputData("I", 39, "", listInputData);
            InputData("J", 40, "", listInputData);
            InputData("K", 41, "", listInputData);
            InputData("L", 42, "", listInputData);
            InputData("M", 43, "", listInputData);
            InputData("N", 44, "", listInputData);
            InputData("O", 45, "", listInputData);
            InputData("P", 46, "", listInputData);
            InputData("Q", 47, "", listInputData);
            InputData("R", 48, "", listInputData);
            InputData("S", 49, "", listInputData);
            InputData("T", 50, "", listInputData);
            InputData("U", 51, "", listInputData);
            InputData("V", 52, "", listInputData);
            InputData("W", 53, "", listInputData);
            InputData("X", 54, "", listInputData);
            InputData("Y", 55, "", listInputData);
            InputData("Z", 56, "", listInputData);
            InputData("[", 57, "", listInputData);
            InputData("]", 58, "", listInputData);
            InputData("^", 59, "", listInputData);
            InputData("_", 60, "", listInputData);
            InputData("`", 61, "", listInputData);
            InputData("a", 62, "", listInputData);
            InputData("b", 63, "", listInputData);
            InputData("c", 64, "", listInputData);
            InputData("d", 65, "", listInputData);
            InputData("e", 66, "", listInputData);
            InputData("f", 67, "", listInputData);
            InputData("g", 68, "", listInputData);
            InputData("h", 69, "", listInputData);
            InputData("i", 70, "", listInputData);
            InputData("j", 71, "", listInputData);
            InputData("k", 72, "", listInputData);
            InputData("l", 73, "", listInputData);
            InputData("m", 74, "", listInputData);
            InputData("n", 75, "", listInputData);
            InputData("o", 76, "", listInputData);
            InputData("p", 77, "", listInputData);
            InputData("q", 78, "", listInputData);
            InputData("r", 79, "", listInputData);
            InputData("s", 80, "", listInputData);
            InputData("t", 81, "", listInputData);
            InputData("u", 82, "", listInputData);
            InputData("v", 83, "", listInputData);
            InputData("w", 84, "", listInputData);
            InputData("x", 85, "", listInputData);
            InputData("y", 86, "", listInputData);
            InputData("z", 87, "", listInputData);
            InputData("{", 88, "", listInputData);
            InputData("|", 89, "", listInputData);
            InputData("}", 90, "", listInputData);
            InputData("~", 91, "", listInputData);
            //InputData("\t", 92, "", listInputData);
            //InputData("\n", 93, "", listInputData);
            //InputData("\"", 94, "", listInputData);
            //InputData("\'", 95, "", listInputData);
            //InputData("\\", 96, "", listInputData);
            return listInputData;
        }
    }
}
