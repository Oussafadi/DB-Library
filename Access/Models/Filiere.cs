namespace DataAccess
{
    public class Filiere : Model
    {
        public string code = "";
        public string designation = "";
        public override string ToString() {
            return $"{this.code}: {this.designation}";
        }
    }
}
