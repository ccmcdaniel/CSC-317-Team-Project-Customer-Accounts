class ParkedCars {
    //instance variables (parallel arrays)
    List<string> make = new List<string>();
    List<string> model = new List<string>();
    List<string> color = new List<string>();
    List<int> licenseNum = new List<int>();

    //constructor
    public ParkedCars() {}

    //getters
    public string[] getCar(int index) {
        //check index validity
        if(make.Count < index || index < 0) { return new string[4] {"","","",""}; }

        return new string[4] { make[index], model[index], color[index], licenseNum[index].ToString() };
    }

    //setters
    public bool setCar(int index, string make_t, string model_t, string color_t, int licenseNum_t) {
        //check index validity
        if(make.Count < index || index < 0) { return false; }

        make[index] = make_t;
        model[index] = model_t;
        color[index] = color_t;
        licenseNum[index] = licenseNum_t;
        
        return true;
    }

    //other methods
    public void addCar(string make_t, string model_t, string color_t, int licenseNum_t) {
        make.Add(make_t);
        model.Add(model_t);
        color.Add(color_t);
        licenseNum.Add(licenseNum_t);
    }

    public bool removeCar(int index) {
        //check index validity
        if(make.Count < index || index < 0) { return false; }

        make.RemoveAt(index);
        model.RemoveAt(index);
        color.RemoveAt(index);
        licenseNum.RemoveAt(index);

        return true;
    }

    private void printSeperator(int len0, int len1, int len2, int len3, char seperator, char corner) {
        string line = corner.ToString() + ' ';
        for(int tmp = 0; tmp < len0; tmp++) { line += seperator.ToString(); } line += ' '+ corner.ToString() +' ';
        for(int tmp = 0; tmp < len1; tmp++) { line += seperator.ToString(); } line += ' '+ corner.ToString() +' ';
        for(int tmp = 0; tmp < len2; tmp++) { line += seperator.ToString(); } line += ' '+ corner.ToString() +' ';
        for(int tmp = 0; tmp < len3; tmp++) { line += seperator.ToString(); } line += ' '+ corner.ToString();
        Console.WriteLine(line);
    }

    public void printCars() {
        if(make.Count == 0) { Console.WriteLine("There are no cars here.\n"); return; }

        //get maximum lengths
        int maximum_make_length = "Make".Length, maximum_model_length = "Model".Length, maximum_color_length = "Color".Length, maximum_licenseNum_length = "LicenseNumber".Length;
        for(int tmp = 0; tmp < make.Count; tmp++) {
            if(maximum_make_length < make[tmp].Length) { maximum_make_length = make[tmp].Length; }
            if(maximum_model_length < model[tmp].Length) { maximum_model_length = model[tmp].Length; }
            if(maximum_color_length < color[tmp].Length) { maximum_color_length = color[tmp].Length; }
            if(maximum_licenseNum_length < licenseNum[tmp].ToString().Length) { maximum_licenseNum_length = licenseNum[tmp].ToString().Length; }
        }

        //print header
        printSeperator(maximum_make_length, maximum_model_length, maximum_color_length, maximum_licenseNum_length, '-', '+');
            string line = "| Make";
            for(int tmp = 0; tmp < maximum_make_length-"Make".Length; tmp++) { line += " "; } line += " | Model";
            for(int tmp = 0; tmp < maximum_model_length-"Model".Length; tmp++) { line += " "; } line += " | Color";
            for(int tmp = 0; tmp < maximum_color_length-"Color".Length; tmp++) { line += " "; } line += " | LicenseNumber";
            for(int tmp = 0; tmp < maximum_licenseNum_length-"LiscenseNumber".ToString().Length; tmp++) { line += " "; } line += " |";
            Console.WriteLine(line);

        printSeperator(maximum_make_length, maximum_model_length, maximum_color_length, maximum_licenseNum_length, '-', '+');
        //print body
        for(int tmp0 = 0; tmp0 < model.Count; tmp0++) {
            line = "| " + make[tmp0];
            for(int tmp = 0; tmp < maximum_make_length-make[tmp0].Length; tmp++) { line += " "; } line += " | " + model[tmp0];
            for(int tmp = 0; tmp < maximum_model_length-model[tmp0].Length; tmp++) { line += " "; } line += " | " + color[tmp0];
            for(int tmp = 0; tmp < maximum_color_length-color[tmp0].Length; tmp++) { line += " "; } line += " | " + licenseNum[tmp0].ToString();
            for(int tmp = 0; tmp < maximum_licenseNum_length-licenseNum[tmp0].ToString().Length; tmp++) { line += " "; } line += " |";
            Console.WriteLine(line);
        }
        //print footer
        printSeperator(maximum_make_length, maximum_model_length, maximum_color_length, maximum_licenseNum_length, '-', '+');
        Console.WriteLine();
    }

}