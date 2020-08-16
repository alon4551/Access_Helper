using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Row{

     List<Col> Columes { get; set; } = new List<Col>();

    public Row(List<Col> cols)
    {
        Columes = cols;
    }
    public Row()
    {

    }
    public List<Col> GetColumes() { return Columes; }

    private bool ExistColume(Col col)
    {
        foreach (Col colume in Columes)
            if (colume.GetField() == col.GetField())
                return true;
        return false;
    }
    private bool ExistColume(string key)
    {
        foreach (Col colume in Columes)
            if (colume.GetField() == key)
                return true;
        return false;
    }
    public void AddColume(Col col)
    {
        if(ExistColume(col)==false)
            Columes.Add(col);
    }
    public void AddColume(string field,object value)
    {
        if(ExistColume(field)==false)
            Columes.Add(new Col(field, value));
    }
    public void AddColume(Col col,int index)
    {
        if (ExistColume(col) == false)
            return;
        List<Col> cols = new List<Col>();
        if (index < Columes.Count)
        {
            for (int i = 0; i < Columes.Count;)
            {
                if (index == i)
                    cols.Add(col);
                else
                {
                    cols.Add(Columes[i]);
                    i++;
                }
            }
            Columes = cols;
        }
        else
            Columes.Add(col);
    }
    public void AddColume(string field, object value,int index)
    {

        if (ExistColume(field) == false)
            return;
        List<Col> cols = new List<Col>();
        if (index < Columes.Count)
        {
            for (int i = 0; i < Columes.Count;)
            {
                if (index == i)
                    cols.Add(new Col(field, value));
                else
                {
                    cols.Add(Columes[i]);
                    i++;
                }
            }
            Columes = cols;
        }
        else
            Columes.Add(new Col(field, value));
        
    }
    public void DeleteColume(int index)
    {
        Columes.RemoveAt(index);
    }
    public void DeleteColume(string key)
    {
        foreach(Col col in Columes)
        {
            if (col.GetField() == key)
            {
                Columes.Remove(col);
                return;
            }
        }
    }
    public object GetColValue(string key)
    {
        foreach (Col col in Columes)
            if (col.GetField() == key)
                return col.GetValue();
        return null;
    }
    public object GetColValue(int index)
    {
        try
        {
            return Columes[index].GetValue();
        }
        catch
        {
            return null;

        }
    }
    public void UpdateColume(Col New_data,Col colume) { 
    
    foreach(Col col in Columes)
        {
            if (col.GetField() == colume.GetField())
            {
                col.Set(New_data);
                return;
            }
        }
            }
    public void UpdateColume(Col New_data,int index) { }
    public void UpdateColume(List<Col> New_data,List<Col> Cols) { }
}

