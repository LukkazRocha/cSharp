namespace ExercicioPOO08 {
    internal class Room {

        public string Name { get; set; }
        public string Email { get; set; }
        public int RoomNumber { get; set; }

        public Room(string name, string email, int roomNumber) {
            Name = name;
            Email = email;
            RoomNumber = roomNumber;
        }

        public override string ToString() {
            return RoomNumber + ": " + Name + ", " + Email;
                
        }
    }
}
