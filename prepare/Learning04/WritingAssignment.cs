class WritingAssignment:Assignment
{
 private string _title;

 public WritingAssignment(string name, string topic, string title):base(name, topic)
 {
  _title = title;

 }

 public string title
 {
  get
  {
   return _title;
  }
 }

 public string GetWritingInformation()
 {
  return ($"{title} by {name}");
 }



}