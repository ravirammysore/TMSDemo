using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

using TempleManagement.Data.Entities;
using TMSDemo.Data;

using TMSDemo.Data.Migrations;
using System.Data.Entity;

namespace TMSDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            SetupData();
        }

        BackgroundWorker bw;
        private void SetupData()
        {                             
            lblProcessing.Text = "Setting up data please wait...";

            bw = new BackgroundWorker();
            bw.DoWork += Bw_DoWork;
            bw.RunWorkerCompleted += Bw_RunWorkerCompleted;

            bw.RunWorkerAsync();
        }

        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {           
            try
            {
                var initializer = new MigrateDatabaseToLatestVersion<TempleContext, Configuration>();
                Database.SetInitializer(initializer);
                using (var ctx = new TempleContext())
                {
                    if (!ctx.PrasadamTypes.Any())
                    {
                        var prasadamTypes = new List<PrasadamType>()
                        {
                            new PrasadamType()
                            {
                                Name = "Sweet",
                                Prasadams = new List<Prasadam>()
                                {
                                    new Prasadam() { Name="Laddu",UnitPrice=5},
                                    new Prasadam() { Name="Mithai", UnitPrice = 10}
                                }
                            },

                            new PrasadamType()
                            {
                                Name = "Rice",
                                Prasadams = new List<Prasadam>()
                                {
                                    new Prasadam() { Name="Lemon Rice",UnitPrice=10},
                                    new Prasadam() { Name="Palak Rice", UnitPrice = 20}
                                }
                            }
                        };
                        ctx.PrasadamTypes.AddRange(prasadamTypes);
                    }

                    if (!ctx.Priests.Any())
                    {
                        var priests = new List<Priest>()
                        {
                            new Priest(){Name="Krishna",LockerNumber =101},
                            new Priest(){ Name="Rama", LockerNumber =102}
                        };
                        priests.First().Vehicles.Add(new Vehicle() { Brand = "Bajaj" });
                        ctx.Priests.AddRange(priests);
                    }

                    ctx.SaveChanges();
                    e.Result = "Ready!";
                }
            }
            catch (Exception ex)
            {
                e.Result = ex.Message;
            }            
        }
    
        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {          
            lblProcessing.Text = e.Result.ToString();
        }

        private void btnShowPrasadam_Click(object sender, EventArgs e)
        {
            using (var ctx = new TempleContext())
            {
                var typename = ctx.Prasadams.FirstOrDefault()?.PrasadamType.Name ?? "NA";
                MessageBox.Show(typename);
            }
        }

        private void btnDeletePrasadamType_Click(object sender, EventArgs e)
        {
            using (var ctx = new TempleContext())
            {
                var prasadamType = ctx.PrasadamTypes.Find(1);
                ctx.PrasadamTypes.Remove(prasadamType);
                try
                {
                    ctx.SaveChanges();
                    MessageBox.Show("Removed");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCreatePriest_Click(object sender, EventArgs e)
        {
            using (var ctx = new TempleContext())
            {
                try
                {
                    var priest = new Priest()
                    {
                        Name = "Keshava",                       
                        LockerNumber = 201                        
                    };

                    ctx.Priests.Add(priest);
                    ctx.SaveChanges();
                    MessageBox.Show("Added");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
            }
        }

        private void btnCreateDistribution_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new TempleContext())
                {
                    var laddu = ctx.Prasadams.Single(p => p.Name == "Laddu");
                    var rice = ctx.Prasadams.Single(p => p.Name == "Lemon Rice");

                    var distribution = new Distribution()
                    {
                        Priest = ctx.Priests.First(),                        
                        DateOfDistribution = DateTime.Today,
                        Distribution_Details = new List<Distribution_Detail>()
                        {
                            new Distribution_Detail()
                            {                                
                                Prasadam = laddu,
                                Quantity = 100,
                                UnitPrice = laddu.UnitPrice
                            },

                            new Distribution_Detail()
                            {
                                Prasadam = rice,
                                Quantity = 100,
                                UnitPrice = rice.UnitPrice,
                            }
                        }
                    };

                    ctx.Distributions.Add(distribution);
                    
                    ctx.SaveChanges();
                    
                    MessageBox.Show("Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowDistribution_Click(object sender, EventArgs e)
        {
            using (var ctx = new TempleContext())
            {
                var priest = ctx.Priests.FirstOrDefault();

                var distributions = priest?
                    .Distributions.Where(d => d.DateOfDistribution <= DateTime.Today);

                decimal sum = 0;
                if (distributions.Any())
                {
                    var details = distributions.SelectMany(d => d.Distribution_Details);

                    if (details.Any()) sum = details.Sum(c => c.UnitPrice * c.Quantity);
                }
                var msg = $"Priest has made {distributions.Count()} distributions until today, amounting to Rs.{sum}";
                MessageBox.Show(msg);
            }
        }
    }
}
