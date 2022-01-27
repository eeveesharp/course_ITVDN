using System;
using System.Collections.Generic;
using System.Text;

namespace DZ1
{
    class ClassRoom
    {
        readonly Random random = new Random();

        readonly Pupil[] pupils = new Pupil[4];
        public ClassRoom(Pupil pupil_1, Pupil pupil_2)
        {
            pupils[0] = pupil_1;
            pupils[1] = pupil_2;
            pupils[2] = GenerationPupil();
            pupils[3] = GenerationPupil();
        }
        public ClassRoom(Pupil pupil_1, Pupil pupil_2, Pupil pupil_3)
        {
            pupils[0] = pupil_1;
            pupils[1] = pupil_2;
            pupils[2] = pupil_3;
            pupils[3] = GenerationPupil();
        }
        public ClassRoom(Pupil pupil_1, Pupil pupil_2, Pupil pupil_3, Pupil pupil_4)
        {
            pupils[0] = pupil_1;
            pupils[1] = pupil_2;
            pupils[2] = pupil_3;
            pupils[3] = pupil_4;
        }

        public void Study()
        {
            foreach (Pupil p in pupils)
            {
                p.Study();
            }
        }

        public void Read()
        {
            foreach (Pupil p in pupils)
            {
                p.Read();
            }
        }

        public void Write()
        {
            foreach (Pupil p in pupils)
            {
                p.Write();
            }
        }

        public void Relax()
        {
            foreach (Pupil p in pupils)
            {
                p.Relax();
            }
        }

        private Pupil GenerationPupil()
        {
            int r = random.Next(1, 4);

            switch (r)
            {
                case 1:
                    {
                        return new ExcelentPupil();
                    }
                case 2:
                    {
                        return new GoodPupil();
                    }
                case 3:
                    {
                        return new BadPupil();
                    }
            }

            return new GoodPupil();
        }
    }
}
