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
