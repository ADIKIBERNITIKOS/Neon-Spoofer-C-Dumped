﻿

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace KeyAuth
{
  public class json_wrapper
  {
    private DataContractJsonSerializer serializer;
    private object current_object;

    public static bool is_serializable(Type to_check) => to_check.IsSerializable || to_check.IsDefined(typeof (DataContractAttribute), true);

    public json_wrapper(object obj_to_work_with)
    {
      this.current_object = obj_to_work_with;
      Type type = this.current_object.GetType();
      this.serializer = new DataContractJsonSerializer(type);
      if (!json_wrapper.is_serializable(type))
        throw new Exception(string.Format("the object {0} isn't a serializable", this.current_object));
    }

    public object string_to_object(string json)
    {
      using (MemoryStream memoryStream = new MemoryStream(Encoding.Default.GetBytes(json)))
        return serializer.ReadObject((Stream) memoryStream);
    }

    public T string_to_generic<T>(string json) => (T) this.string_to_object(json);
  }
}
