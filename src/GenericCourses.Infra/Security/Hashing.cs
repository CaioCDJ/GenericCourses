namespace GenericCourses.Infra.Security;

using BCrypt.Net;

class Hasing {

    public static string hash(string password)
      => BCrypt.HashPassword(password);

    public static bool verify(string password, string hash)
      => BCrypt.Verify(password, hash);

}
