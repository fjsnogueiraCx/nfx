﻿/*<FILE_LICENSE>
* NFX (.NET Framework Extension) Unistack Library
* Copyright 2003-2018 Agnicore Inc. portions ITAdapter Corp. Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
</FILE_LICENSE>*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using NFX.Scripting;

using NFX.IO.ErrorHandling;

namespace NFX.UTest.IO
{
    [Runnable(TRUN.BASE)]
    public class ChecksumsTests
    {
        [Run]
        public void CRC32_1()
        {
            Aver.AreEqual( UInt32.Parse("D6C12026", System.Globalization.NumberStyles.HexNumber) , 
                              CRC32.ForEncodedString("Hello Dolly!", System.Text.Encoding.ASCII)); 
        }

        [Run]
        public void CRC32_2()
        {
            Aver.AreEqual( UInt32.Parse("664EF010", System.Globalization.NumberStyles.HexNumber) ,
                              CRC32.ForEncodedString("This is an example of a much longer string of characters", System.Text.Encoding.ASCII)); 
        }

        [Run]
        public void CRC32_3()
        {
            Aver.AreEqual( UInt32.Parse("D6C12026", System.Globalization.NumberStyles.HexNumber) , 
                              CRC32.ForString("Hello Dolly!")); 
        }

        [Run]
        public void CRC32_4()
        {
            Aver.AreEqual( UInt32.Parse("664EF010", System.Globalization.NumberStyles.HexNumber) ,
                              CRC32.ForString("This is an example of a much longer string of characters")); 
        }

        [Run]
        public void CRC32_5()
        {
            Aver.AreEqual( UInt32.Parse("CBF43926", System.Globalization.NumberStyles.HexNumber) ,
                              CRC32.ForString("123456789")); 
        }


        [Run]
        public void Adler32_1()
        {
            Aver.AreEqual( UInt32.Parse("1BE9043A", System.Globalization.NumberStyles.HexNumber) ,
                              Adler32.ForEncodedString("Hello Dolly!", System.Text.Encoding.ASCII)); 
        }

        [Run]
        public void Adler32_2()
        {
            Aver.AreEqual( UInt32.Parse("36E81466", System.Globalization.NumberStyles.HexNumber) ,
                              Adler32.ForEncodedString("This is an example of a much longer string of characters", System.Text.Encoding.ASCII)); 
        }

        [Run]
        public void Adler32_3()
        {
            Aver.AreEqual( UInt32.Parse("1BE9043A", System.Globalization.NumberStyles.HexNumber) ,
                              Adler32.ForString("Hello Dolly!")); 
        }

        [Run]
        public void Adler32_4()
        {
            Aver.AreEqual( UInt32.Parse("36E81466", System.Globalization.NumberStyles.HexNumber) ,
                              Adler32.ForString("This is an example of a much longer string of characters")); 
        }


        [Run]
        public void Adler32_5()
        {
            Aver.AreEqual( UInt32.Parse("11E60398", System.Globalization.NumberStyles.HexNumber) ,
                              Adler32.ForString("Wikipedia")); 
        }
    }
}
