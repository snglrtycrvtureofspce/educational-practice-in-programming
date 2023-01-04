using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.CompilerServices;
namespace Day18
{
    public abstract class Serialization<Type>
    {
        public string NameFile { get; set; } = null;
        public abstract void Serialize(Type data);
        public abstract Type Deserialize();
    }

    public class JsonSerialization<Type> : Serialization<Type>
    {
        private DataContractJsonSerializer Serializer;

        public JsonSerialization(string nameFile)
        {
            Serializer = new DataContractJsonSerializer(typeof(Type));

            if (NameFile is null)
            {
                throw new ArgumentNullException("NameFile is null!");
            }

            NameFile = nameFile;
        }
        public override void Serialize(Type data)
        {
            
        }
        public override Type Deserialize()
        {
            throw new System.NotImplementedException();
        }

        
    }
}