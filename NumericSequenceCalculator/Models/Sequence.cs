using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace NumericSequenceCalculator.Models
{
    /// <summary>
    /// Sequence
    /// </summary>
    public class Sequence
    {
        #region Variables

        private int number = 0;
        private string seq_01 = "";
        private string seq_02 = "";
        private string seq_03 = "";
        private string seq_04 = "";
        private string seq_05 = "";

        #endregion


        public Sequence(int number)
        {
            this.number = number;
        }


        #region Methods

        public void Calculate()
        {
            int p1 = 1, p2 = 1;

            for (int i = 1; i <= number; i++)
            {
                seq_01 = seq_01 + i + ", ";

                if (i % 2 != 0)
                    seq_02 = seq_02 + i + ", ";
                else
                    seq_03 = seq_03 + i + ", ";

                if((i % 3 == 0) && (i % 5 == 0))
                    seq_04 = seq_04 + "Z, ";
                else if(i % 3 == 0)
                    seq_04 = seq_04 + "C, ";
                else if (i % 5 == 0)
                    seq_04 = seq_04 + "E, ";
                else
                    seq_04 = seq_04 + i + ", ";

                if (i == 1)
                    seq_05 = "1, 1, ";
                else if (p1 + p2 == i)
                {
                    seq_05 = seq_05 + i + ", ";
                    p1 = p2;
                    p2 = i;
                }
            }

            seq_01 = fixLen(seq_01);
            seq_02 = fixLen(seq_02);
            seq_03 = fixLen(seq_03);
            seq_04 = fixLen(seq_04);
            seq_05 = fixLen(seq_05);
        }

        private string fixLen(string s)
        {
            if (s.Length > 0) s = s.Substring(0, s.Length - 2);
            return s;
        }

        #endregion


        #region Properties

        public string Sequence_01
        {
            get { return seq_01; }
            set { seq_01 = value; }
        }

        public string Sequence_02
        {
            get { return seq_02; }
            set { seq_02 = value; }
        }

        public string Sequence_03
        {
            get { return seq_03; }
            set { seq_03 = value; }
        }

        public string Sequence_04
        {
            get { return seq_04; }
            set { seq_04 = value; }
        }

        public string Sequence_05
        {
            get { return seq_05; }
            set { seq_05 = value; }
        }

        #endregion
    }
}