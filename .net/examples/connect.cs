// mcs -r:Conreality -r:Npgsql -r:System.Data connect.cs && mono connect.exe

using Conreality;

public class Connect {
  public static void Main() {

    using (var client = new Conreality.Client()) {
      // TODO
    }
  }
}
