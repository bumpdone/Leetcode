    public static int NumUniqueEmails(string[] emails)
    {
      var result = new HashSet<string>();
      foreach (var email in emails)
      {
        var suffixIndex = email.LastIndexOf("@");
        var prefix = email.Substring(0, suffixIndex).Replace(".", "");
        var suffix = email.Substring(suffixIndex);

        var plusIndex = prefix.IndexOf("+");
        if (plusIndex > 0)
        {
          prefix = prefix.Substring(0, plusIndex);
        }
        result.Add(prefix + suffix);
      }
      return result.Count;
    }
