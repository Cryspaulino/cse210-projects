public class Teacher : Staff {
    protected int _roomNumber;

public Teacher(string firstName, string lastName, string gender, int roomNumber) 
:base (firstName, lastName, gender) {
    _roomNumber = roomNumber;
}

    public string GetGreeting() {
        return $"Hello students, I am {_gender}. {_lastName}. I teach in room {_roomNumber}";
    }

}