namespace IndexerTest2
{
    class IndexedNames
    {
        private string[] namelist = new string[size];
        public static int size = 10;
        int i;
        public IndexedNames()
        {
            for ( i = 0; i < size; i++)
            {
                namelist[i] = "N.A";
            }
        }


        //this will be shown in the git branch mainbranch
        public string this[int index]
        {
            get
            {
                string tmp;
                if (index >= 0 && index < size - 1)
                {
                    tmp = namelist[index];
                }
                else
                {
                    tmp = " ";
                }
                return (tmp);
            }
            set
            {
                if (index >= 0 && index < size - 1)
                {
                    namelist[index] = value;
                }
            }
        }


        //this will be shown in the git branch master and sidebranch
        public int this[string name]
        {
            get
            {
                int index = 0;
                while (index < size)
                {
                    if (namelist[index] == name)
                    {
                        return index;
                    }
                    index++;
                }
                return index;
            }
        }
    }
}
