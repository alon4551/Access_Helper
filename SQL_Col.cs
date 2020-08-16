using System.Collections.Generic;

public class Col
{
    private string Field {get;set;}
    private object Value {get;set;}

    /// <summary>
    /// Create a Column
    /// </summary>
    /// <param name="field"></param>
    /// <param name="value"></param>
    public Col(string field, object value)
    {
        Set(field, value);
    }
    public void Set(string field, object value)
    {
        Field = field;
        Value = value;
    }
    public void Set(Col col)
    {
        Field = col.GetField();
        Value = col.GetValue();
    }
    public object GetValue() {
        return Value;
    }
    public string GetField() {
        return Field;
    }
    public string Value_SQL_Syntax()
    {
        switch (Value.GetType().ToString())
        {

            case "System.String":
                {
                    return $"'{Value.ToString()}'";

                }
            default:
                {
                    return $"{Value.ToString()}";
                }
        }
    }
    public static List<Col> Get_SQL_Values(List<string> fields, List<object> values)
    {
        List<Col> list = new List<Col>();
        for (int i = 0; i < fields.Count && i < values.Count; i++)
            list.Add(new Col(fields[i], values[i]));
        return list;
    }
    public static string Values_SQL_Syntax(List<Col> Values, string Seperater)
    {
        string syntax = "";
        int i = 0;
        foreach (Col update in Values)
        {

            syntax += $"{update.Field}={update.Value_SQL_Syntax()}";
            if (i != Values.Count - 1)
            {
                syntax += $"{Seperater}";
            }
        }
        return syntax.Trim(Seperater.ToCharArray()).Trim();
    }
    public static string Values_SQL_Syntax(List<string> Values, string Seperater)
    {
        string syntax = "";
        int i = 0;
        foreach (string update in Values)
        {
            syntax += $"{update}";
            if (i != Values.Count - 1)
                syntax += $"{Seperater}";
            i++;
        }
        return syntax.Trim(Seperater.ToCharArray()).Trim();
    }

}