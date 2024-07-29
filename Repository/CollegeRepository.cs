using WebApi.Models;

namespace WebApi.Repository
{
    public static class CollegeRepository
    {
        public static List<student> Student { get; set; } = new List<student>()
        {
            new student {
                Id = 1,
                Name = "Prince Magutshwa",
                Email = "p@gmail.com"
            },
            new student{
                Id = 2,
                Name = "Elon Magutshwa",
                Email = "e@gmail.com"
            }
        };
    }
}
