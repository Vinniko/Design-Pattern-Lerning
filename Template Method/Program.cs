using System;
using Template_Method.Interfaces;
using Template_Method.Services;

namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            IReader fileReader = new TxtFileReader();
            IParser fileParser = new TxtFileParser();
            IReader jsonReader = new JsonReader();
            IParser jsonParser = new JsonParser();
            IService fileService = new FileService("some path", fileReader, fileParser);
            IService jsonService = new JsonService("some url", jsonReader, jsonParser);
            fileService.Run();
            jsonService.Run();
        }
    }
}
