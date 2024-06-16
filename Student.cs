using NameGenerator.Generators;

public class Student {
    private String name;
    private int age;

    public Student(String name, int age) {
        this.name = name;
        this.age = age;
    }

    public String getName() { return name; }
    public int getAge() { return age;}

    public static String getRandomName () { 
        RealNameGenerator g = new RealNameGenerator(); 
        return g.Generate();
    }
}