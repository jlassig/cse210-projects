class Assignment
{
 private string _studentName;
 private string _topic;

 public Assignment(string name, string topic)
 {
  _studentName = name;
  _topic = topic;

 }

 public string name
 {
  get
  {
   return _studentName;
  }

 }
public string topic
{
 get
 {
   return _topic;
 }

}
public string GetSummary()
{
 return ($"{name} - {topic}");
}


}