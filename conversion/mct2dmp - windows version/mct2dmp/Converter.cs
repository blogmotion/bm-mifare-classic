﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mct2dmp
{
    public class Dump
    {
        public List<string> Lines { get; set; }
        public int LinesCount { get; } = 80;
        public List<byte> BinaryOutput { get; set; } = new List<byte>();

        public string TextOutput { get; set; }
    }
    public enum FileType
    {
        Text, Binary
    }
    public class DumpConverter
    {

        FileType FileType { get; set; }
        String FileText { get; set; }
        public FileType CheckDump(string filename)
        {
            FileText = File.ReadAllText(filename);
            if (FileText.ToString().StartsWith("+Sector:"))
                return FileType.Text;
            else
                return FileType.Binary;


        }
        public Dump ConvertToBinaryDump()
        {
            var ret = new List<Byte>();
            var md = new Dump()
            {
                Lines = FileText.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None).ToList()
            };
            foreach (var line in md.Lines.Where(l => !l.StartsWith("+Sector")))
            {
                md.BinaryOutput.AddRange(StringToByteArray(line));
            }
            return md;
        }

        public Dump ConvertToTextDump(string filename)
        {
            var bytesData = File.ReadAllBytes(filename);
            string hex = BitConverter.ToString(bytesData).Replace("-", string.Empty);
            var md = new Dump();
          
            md.Lines = Split(hex, 32);
            int sector = (md.Lines.Count - 4) / 4;
            for (int i = md.Lines.Count - 4; i >= 0; i -= 4)
                md.Lines.Insert(i, $"+Sector: {sector--}\r\n");

            md.TextOutput = new string(md.Lines.SelectMany(c => c).ToArray());


            return md;
        }

        public byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length).Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16)).ToArray();
        }
        static List<string> Split(string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize) + "\r\n").ToList();
        }
    }
}
