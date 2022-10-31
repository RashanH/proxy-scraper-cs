System.Net.HttpWebResponse response = request.GetResponse;
	System.IO.StreamReader SiteSource = new System.IO.StreamReader(response.GetResponseStream());
	string UseSource = SiteSource.ReadToEnd;
	int SplitVar = 0;
	bool Port = false;
	bool useport = false;
	string portval = null;
	Regex reg = default(Regex);
