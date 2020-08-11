### SQL_Generator
this are files that helps developer create there own sql queris without dealing with syntax
for this projects there are ***3*** basic classes that help build the SQL Queries:
  -Col
  -Row
  -condition

class **Col** has props of :
```
  private string Field {get;set;}//the field name of a colume
  private object Value {get;set;}//the value of the field (can be any value)
```
class **Col** has constractor and actions that sets and gets the props above:
```
    public Col(string field, object value){//constractor
        Set(field, value);
    }
    public void Set(string field, object value){
        Field = field;
        Value = value;
    }
    public void Set(Col col){
        Field = col.GetField();
        Value = col.GetValue();
    }
    public object GetValue() {
        return Value;
    }
    public string GetField() {
        return Field;
    }
```
