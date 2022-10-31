f (Form1.ListBox1.SelectedItem.ToString.Contains("http://www.proxynova.com/proxy-server-list/")) {
		reg = new Regex("<span class=\"row_proxy_ip\">.*");
		//
		SplitVar = 1;
		useport = true;
		if (Form1.ListBox1.SelectedItem.ToString.Contains("/port-80/")) {
			portval = "80";
		} else if (Form1.ListBox1.SelectedItem.ToString.Contains("/port-8080/")) {
			portval = "8080";
		}
	}

if (Information.IsNumeric(z(0))) {
			Form1.lstproxies.Items.Add(z);
			Form1.lstproxies.SelectedIndex = 0;
		}

foreach (Match ProxyString in Matches) {
		string x = ProxyString.Value.Split(">").GetValue(SplitVar);
		string z = x.Split("<").GetValue(0);
	
	 else if (Form1.ListBox1.SelectedItem.ToString.Contains("http://proxy-list.org/")) {
		reg = new Regex("<li class=\"proxy\">.*</li>");
		SplitVar = 1;
	}

	
	if (Form1.ListBox1.SelectedItem.ToString.Contains("http://proxy-list.org/")) {
		reg = new Regex("<li class=\"proxy\">.*</li>");
		SplitVar = 1;
	}

	
		if (Port) {
			string o = ProxyString.Value.Split(">").GetValue(4);
			string d = o.Split("<").GetValue(0);
			z = z + ":" + d;
		} 
