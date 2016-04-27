﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Serial
{
    public class Class1
    {
        public Mensaje LoadMensaje(byte[] binaryObj)
        {
            using (System.IO.MemoryStream stream = new System.IO.MemoryStream(binaryObj))
            {
                stream.Position = 0;
                object desObj = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter().Deserialize(stream);
                return (Mensaje)desObj;
            }
        }
        public byte[] SerializarObj(Mensaje obj)
        {
            using (System.IO.MemoryStream stream = new System.IO.MemoryStream())
            {
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                formatter.Serialize(stream, obj);

                byte[] bytes = stream.ToArray();
                stream.Flush();

                return bytes;
            }
        }
    }
}
