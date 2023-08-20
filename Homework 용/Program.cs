using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Mainprogram: TextFileReader
    {
        static void Main(string[] args)
        {
            Console.WriteLine("파일 명을 입력해주세요");
            string fileName = Console.ReadLine();
            string[] textFile = TextFileReader.txtImport(fileName);
            for(int i = 0; i < textFile.Length; i++)
            {
                Console.WriteLine(textFile[i]);
            }
        }
    }
}
