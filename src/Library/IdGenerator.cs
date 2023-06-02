using System;

namespace ClassLibrary;

public class IdGenerator
{
    public int GenerateId()
    {
        Random random = new Random();
        int id = random.Next(1000);
        return id;
    }
}