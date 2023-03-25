using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Models;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem
{
    public class AppDbInitializer
    {
        /*private readonly DataContext dataContext;*/

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using var serviceScope = applicationBuilder.ApplicationServices.CreateScope();
            var context = serviceScope.ServiceProvider.GetService<DataContext>();

            context.Database.EnsureCreated();

            if (!context.Employees.Any())
            {
                context.Employees.AddRange(new List<Employee>()
                {

                    new Employee()
                    {
                        FirstName = "Bob",
                        LastName = "Builder",
                        DOB = new DateTime(1985, 06, 10),
                        DateJoined = new DateTime(2016, 10, 10),
                        IsActive = true,
                        ImageUrl = "",
                        Email = "Bobthebuilder@fakemail.com",
                        Salary = 60000,
                        Address = new Address()
                        {
                            City = "Ottawa",
                            Country = "Canada",
                            PostalCode = "K1J123",
                            State = "Ontario",
                            Street = "123 Easy Street"
                        },
                        Phones = new List<Phone>()
                        {
                            new Phone()
                            {
                                Type = "Mobile",
                                AreaCode = "613",
                                PhoneNumber = "543-3234",
                            },
                            new Phone()
                            {
                                Type = "Home",
                                AreaCode = "613",
                                PhoneNumber = "325-6031",
                            }


                        },EmployeeTasks = new List<EmployeeTask>()
                        {
                            new EmployeeTask()
                            {
                                Task = new EmpTask() {
                                         Name = "First Task of the Day",
                                         Description = "Creating Landing Page",
                                         TaskStart = new DateTime(2023,03,15),
                                         TaskEnd = new DateTime(2023,03,24),
                                         IsCompleted = true,
                                }



                             }
                        }

                    }, new Employee()
                    {
                        FirstName = "John",
                        LastName = "Doe",
                        DOB = new DateTime(1992, 08, 11),
                        DateJoined = new DateTime(2019, 11, 18),
                        IsActive = true,
                        ImageUrl = "",
                        Email = "johndoe2@fakemail.com",
                        Salary = 120000,
                        Address = new Address()
                        {
                            City = "Ottawa",
                            Country = "Canada",
                            PostalCode = "K2L505",
                            State = "Ontario",
                            Street = "683 Some street"
                        },
                        Phones = new List<Phone>()
                        {
                            new Phone()
                            {
                                Type = "Mobile",
                                AreaCode = "613",
                                PhoneNumber = "643-0483",
                            },
                            new Phone()
                            {
                                Type = "Home",
                                AreaCode = "613",
                                PhoneNumber = "049-8589",
                            }


                        },
                        EmployeeTasks = new List<EmployeeTask>()
                        {
                            new EmployeeTask()
                            {
                                Task = new EmpTask() {
                                         Name = "First Task of the Day",
                                         Description = "Completing Admin Dashboard",
                                         TaskStart = new DateTime(2023,03,20),
                                         TaskEnd = new DateTime(2023,04,26),
                                         IsCompleted = false,
                                }



                            }
                        }

                    }
                });

                    }
                context.SaveChanges();
            }


        }
    }

       
        /*public void SeedDataContext()
        {
            if (!dataContext.EmployeeTasks.Any())
            {
                var employeeTasks = new List<EmployeeTask>();
                {
                    new EmployeeTask()
                    {
                        Employee = new Employee()
                        {
                            FirstName = "Bob",
                            LastName = "Builder",
                            DOB = new DateTime(1985, 06, 10),
                            DateJoined = new DateTime(2016, 10, 10),
                            ImageUrl = "",
                            Email = "Bobthebuilder@fakemail.com",
                            Salary = 60000,
                            Address = new Address()
                            {
                                City = "Ottawa",
                                Country = "Canada",
                                PostalCode = "K1J123",
                                State = "Ontario",
                                Street = "123 Easy Street"
                            },
                            Phones = new List<Phone>()
                            {
                                new Phone() {
                                    Type = "Mobile",
                                    AreaCode = "613",
                                    PhoneNumber = "543-3234",
                                },
                                new Phone()
                                {
                                      Type = "Home",
                                    AreaCode = "613",
                                    PhoneNumber = "325-6031",
                                }


                            }

                        }
                    };
                    dataContext.EmployeeTasks.AddRange(employeeTasks);
                    dataContext.SaveChanges();
                }


            }
        }
    }
}

        
    


    
                    
                
            
        
    

*/