using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace FSImark.Services
{
	#region Abstract class Serializer
	public interface ISerializer
	{
		 T Load<T>(string filePath);
		void Save<T>(string filePath, T serializableObject);
	}
	#endregion

	[Serializable]
	public sealed class BinarySerializer : ISerializer
	{
		public T DeepCopy<T>(T serializableObject)
		{
			using (MemoryStream stream = new MemoryStream())
			{
				BinaryFormatter formatter = new BinaryFormatter();
				formatter.Serialize(stream, serializableObject);
				stream.Seek(0, SeekOrigin.Begin);

				return (T)formatter.Deserialize(stream);
			}
		}
		public void Save<T>(string filePath, T serializableObject)
		{
			using (FileStream fs = File.Create(filePath))
			{
				BinaryFormatter formatter = new BinaryFormatter();
				formatter.Serialize(fs, serializableObject);
			}
		}
		public T Load<T>(string filePath)
		{
			using (FileStream fs = File.Open(filePath, FileMode.Open))
			{
				BinaryFormatter formatter = new BinaryFormatter();
				return (T)formatter.Deserialize(fs);
			}
		}
	}
	[Serializable]
	public sealed class XMLSerializer : ISerializer
	{
		public void Save<T>(string filePath, T serializableObject)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(T));
			using (TextWriter textWriter = new StreamWriter(filePath))
				serializer.Serialize(textWriter, serializableObject);
		}
		public T Load<T>(string filePath)
		{
			try
			{
				XmlSerializer serializer = new XmlSerializer(typeof(T));
				using (TextReader textReader = new StreamReader(filePath))
					return (T)serializer.Deserialize(textReader);
			}
			catch (Exception) { throw; }
		}
	}
}
