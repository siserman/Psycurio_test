using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using UnityEngine.UI;


public class TestPermutation : MonoBehaviour
{
    public Text txt_info;
    public string string_a;

    public string string_b;

    public List<int> list_Letter_num_a = new List<int>();
    public List<int> list_Letter_num_b = new List<int>();

    public Dictionary<char, int> counts2 = new Dictionary<char, int>();

    public SortedDictionary<char, int> counted = new SortedDictionary<char, int>();

    public void SetString_A(string a)
    {
        string_a = a;
    }

    public void SetString_B(string b)
    {
        string_b = b;
    }

    private bool Test_perm(String _str_a, String _str_b)
    {   
        list_Letter_num_a.Clear();

        list_Letter_num_b.Clear();
        
        if (_str_a.Length != _str_b.Length)
        {
            return false;
        }

        var count_chars_a = _str_a.GroupBy(c => c).Select(g => new { Char = g.Key, Count = g.Count() });

        foreach(var c in count_chars_a.OrderBy(key => key.Char))
        {
            list_Letter_num_a.Add(c.Count);
        }

        var count_chars_b = _str_b.GroupBy(c => c).Select(g => new { Char = g.Key, Count = g.Count() });

        foreach(var d in count_chars_b.OrderBy(key => key.Char))
        {
            
            list_Letter_num_b.Add(d.Count);
        }

        for (int i = 0; i < list_Letter_num_a.Count; i++) 
            if (list_Letter_num_a[i] != list_Letter_num_b[i])
                return false; 
        return true;
    }
    
    public void CheckIfPermutation()
    {
        if(Test_perm(string_a, string_b))
        {
            txt_info.text = "Yes";
            Debug.Log("Yes");
        }
        else
            txt_info.text = "No";
            Debug.Log("No");

    }



}
