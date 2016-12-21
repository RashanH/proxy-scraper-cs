public void Scrape()
{
	
	Form1.lstproxies.Items.Clear();
	System.Net.HttpWebRequest request = System.Net.HttpWebRequest.Create(Form1.ListBox1.SelectedItem);
	System.Net.HttpWebResponse response = request.GetResponse;
	System.IO.StreamReader SiteSource = new System.IO.StreamReader(response.GetResponseStream());
	string UseSource = SiteSource.ReadToEnd;
	int SplitVar = 0;
	bool Port = false;
	bool useport = false;
	string portval = null;
	Regex reg = default(Regex);
	if (Form1.ListBox1.SelectedItem.ToString.Contains("http://www.proxynova.com/proxy-server-list/")) {
		reg = new Regex("<span class=\"row_proxy_ip\">.*");
		//
		SplitVar = 1;
		useport = true;
		if (Form1.ListBox1.SelectedItem.ToString.Contains("/port-80/")) {
			portval = "80";
		} else if (Form1.ListBox1.SelectedItem.ToString.Contains("/port-8080/")) {
			portval = "8080";
		}
	} else if (Form1.ListBox1.SelectedItem.ToString.Contains("http://proxy-list.org/")) {
		reg = new Regex("<li class=\"proxy\">.*</li>");
		SplitVar = 1;
	} else if (Form1.ListBox1.SelectedItem.ToString.Contains("http://www.gatherproxy.com/")) {
		reg = new Regex("PROXY_IP\":\".*");
	} else {
		reg = new Regex("<tr><td>.*</td><td>.*</td>");
		SplitVar = 2;
		Port = true;
	}
	MatchCollection Matches = reg.Matches(UseSource);
	foreach (Match ProxyString in Matches) {
		string x = ProxyString.Value.Split(">").GetValue(SplitVar);
		string z = x.Split("<").GetValue(0);
		if (Port) {
			string o = ProxyString.Value.Split(">").GetValue(4);
			string d = o.Split("<").GetValue(0);
			z = z + ":" + d;
		}
		if (useport) {
			z = z.Replace("\t\t  ", "");
			z = z + ":" + portval;
		}
		if (Information.IsNumeric(z(0))) {
			Form1.lstproxies.Items.Add(z);
			Form1.lstproxies.SelectedIndex = 0;
		}
	}
	x:
	return;
}