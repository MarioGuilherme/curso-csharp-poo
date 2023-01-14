namespace ConsoleApp1.Entities {
    public class LogRecord {
        public string Username { get; set; }
        public DateTime Instat { get; set; }

        public override int GetHashCode() {
            return Username.GetHashCode();
        }

        public override bool Equals(object obj) {
            if (obj is not LogRecord) return false;
            LogRecord other = obj as LogRecord;
            return Username.Equals(other.Username);
        }
    }
}