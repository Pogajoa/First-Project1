using UnityEngine;
public class ClassExamples : MonoBehaviour{}
    class Human {
      protected string name;
      protected float height;
     protected int age;
  public string Name{
    get{
      return name;
    }
    set{
      name = value;
    }
  }

  public float Height{
    get{
      return height;
    }
    set{
      height = value;
    }
  }

  public int Age{
    get{
      return age;
    }
    set{
      age = value;
    }
  }

public string GetName(){
   Debug.Log("이름에 접근했다.");
  return name;
}
public void SetName(string value){
   Debug.Log("이름을 수정했다.");
  name = value;
}
      public Human(){}
      public Human(string _name, float _height, int _age){
        this.name = _name;
        this.height = _height;
        this.age = _age;
      }
  public void Eat() {
    Debug.Log("Eat");
    }
  public void Eat(string something) {
    Debug.Log("Eat"+something);
    }
  public virtual void Walk() {
    Debug.Log("Walk");
      }

 public void Sleep() {
    Debug.Log("Sleep");
      }
    }

    