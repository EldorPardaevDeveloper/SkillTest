
using System;

namespace SkillTest
{
    public class TestAction<T>
    {
        public void TestDating()
        {
            Console.WriteLine("   Qiziqqan Kasbni aniqlash testiga xush kelibsiz!");
            Console.WriteLine("\n     Testimiz 10ta savoldan iborat va  \" 0 , 1 , 2 , 3 , 4 \" varyantlaridan birini tanlaysiz!");
            Console.WriteLine("\n        Testni boshlash uchun ixtiyoriy tugmani bosing.");
            Console.ReadKey();
            Console.Clear();
        }
        public void TestQuestionAnswer(int score)
        {
            string[] questions =
{
                    "\n 1:  Siz dangasamisiz?\n\n 0:  Xa\n 1:  Dangasa emasman lenik bo'sh vaqtim ko'p\n 2:  Yo'q\n 3:  Ba'zida\n 4:  Bandman",
                    "\n 2:  Siz qanday insonsiz?\n\n 0:  Bilmayman\n 1:  Pozitiv\n 2:  Hush muomilali\n 3:  Yoqimtoy\n 4:  Aqilli",

                    "\n 3:  Sizning sevimli buyum yoki mashg'ulotingiz?\n\n 0:  Qiziqishim yo'q\n 1:  Pazandalik\n 2:  Xorijiy til\n 3:  Rasm chizish\n 4:  Kompyutir",
                    "\n 4:  Bo'sh vaqtingizda nimalar bilan band bo'lasiz?\n\n 0:  Ichimlik ichaman\n 1:  O'yin o'yneman\n 2:  Sayr qilaman\n 3:  Entirnetda band bo'laman\n 4:  Kitob o'qiman",

                    "\n 5:  Uchrashuvlarda qaysi guruhga qo'shilasiz?\n\n 0:  Hech kimga\n 1:  Tanishlar guruhiga\n 2:  Kulguli guruhga\n 3:  Qiziqarle guruhga\n 4:  Kichik guruhga",
                    "\n 6:  Axborot vositasining qaysi qismini o'qishga intilasiz?\n\n 0:  O'qishni yoqtirmayman\n 1:  Asosiy qismini\n 2:  Qiziqarle qismini\n 3:  Zavqlantiradigan qismini\n 4:  Barchasini",

                    "\n 7:  Sizning sevimli filmingiz?\n\n 0:  Filmlarni yoqtirmayman\n 1:  Komediya\n 2:  Detiktiv\n 3:  Melodramma\n 4:  Xujjatle filmlar",
                    "\n 8:  Reality shouda ishtirok etish imkonyati bo'lsa , qay birini tanlardingiz?\n\n 0:  Mish mish va Munosabatlarni oydinlashtiradiganiga \n 1:  Tajriba orttirediganimga \n 2:  Mashhur bo'lish mumkun bo'lganiga\n 3:  Qobilyatimni namoyish etolediganiga\n 4:  Shoular vaqtni bexuda sovirishdir.",

                    "\n 9:  Kelajakda kimgadir suyanishni istarmidingiz?\n\n 0:  Xa\n 1:  Faqat ish yuzasidan\n 2:  Yoq desam yolg'on bo'ladi\n 3:  Imkonsiz vaziyatlarda\n 4:  Xechqachon",
                    "\n 10:  Quyidagi mashg'ulotlardan qaysi biri maqqul?\n\n 0:  Yalqovlik:  \n 1:  Bilimlarimni murakkab masalalar yechishga qaratish\n 2:  O'rgatish , maslahat berish , yoki kimgadir ko'maklashish.\n 3:  O'z ijodkorlik qobilyatlarimni ishga solish.\n 4:  Beznis rejalar ishlab chiqish",
            };

            foreach (string question in questions)
            {
                Console.Clear();
                Console.WriteLine(question);
                Console.Write("\n Choose: ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input >= 0 && input <= 4)
                {
                    score += input;
                }
                else
                {
                    while (input > 4 || input < 0)
                    {
                        Console.WriteLine("Iltimos Consolga 0dan 4gacha bo'lgan sonlarni kiriting");
                        input = Convert.ToInt32(Console.ReadLine());

                    }
                    score += input;
                }
            }       
            Console.Clear();
            if (score >= 0 && score <= 7)
            {
                Console.WriteLine("  \n\n\n Taxminiy qiziqishingiz:    Valantiyor , Kichik daromad keltiruvchi faolyat turlari .\n\n\n");
            }
            else if (score >= 8 && score <= 15)
            {
                Console.WriteLine("  \n\n\n Taxminiy qiziqishingiz:    Oshpaz , Sportchi , Usta , mehanik , elektirik , santexnik , Murabbiy ,Sotuvchi va Sotuv agenti .\n\n\n");
            }
            if (score >= 16 && score <= 24)
            {
                Console.WriteLine("  \n\n\n Taxminiy qiziqishingiz:     O'qtuvchi  ,  Militsiya  ,  O't o'chiruvchi  ,  Shifokor  ,  tarbiyachi  ,  kadrlar bn ishlovchi hodim  ,  Ijtimoiy mehnat sohasi hodimi .\n\n\n");
            }
            else if (score >= 25 && score <= 32)
            {
                Console.WriteLine("   \n\n\nTaxminiy qiziqishingiz:    Yozuvchi , Rassom , Dizayner , Jurnalist , Muhandis , Fotosuratchi .\n\n\n");
            }
            if (score >= 33)
            {
                Console.WriteLine("   \n\n\nTaxminiy qiziqishingiz:    Tadbirlar tashkilotchisi , Hisobchi , Detiktiv , Yurist , Web dasturchi , dasturchi , Redaktir , Kompanya direktori.\n\n\n");
            }
        }
    }
}
