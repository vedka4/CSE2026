using System;
using System.ComponentModel;

public class Scripture
{
    private List<string> _scripture = new List<string>();
    
    public Scripture(List<string> scriptureTex)
    {
        
    }

    public List<string> GetScripture()
    {
        return _scripture;
    }
}
