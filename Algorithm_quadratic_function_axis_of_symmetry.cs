try{
//This a algorithm for axis of symmetry

             //Declaration
                int res1 = -6;
                int res2 = 24;
                int res3 = -19;

               
             //Validation
                MessageBox.Show("a:" + res1);
                MessageBox.Show("b:"+res2);
                MessageBox.Show("c:"+res3);

                
             //Formula
                int hasil = -res2;
                int hasil2 = 2 * res1;
                int hasil3 = hasil / hasil2;
             //Show
                MessageBox.Show(hasil3.ToString());
            }
            catch(Exception f)
            {
                MessageBox.Show(f.Message);
            }
            
            //pseudocode :)
