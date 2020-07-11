using AutoMapper;
using IonicApi.Dtos;
using IonicApi.Models;

namespace IonicApi.Profiles
{
    public class DrawPlotProfile : Profile
    {
        public DrawPlotProfile()
        {
            CreateMap<PeDrawPlot, PeDrawPlotDto>();
            CreateMap<PeQuestion, QuestionDto>();
            CreateMap<PeUserTestPaperTopic, PaperTopicDto>();

            CreateMap<PeTopic, DrawPlotTopicDto>();
        }
    }
}
