using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using NewXmlWork.Interfaces;
using NewXmlWork.Model;
using System.Data.SqlClient;
using System.Data;

namespace NewXmlWork.Logic
{
    public class DapperHelper : IBetRadarRepository
    {
        public void AddBetType(BetType betType)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@BetType", betType.BetTypeValue);
                p.Add("@EventID", betType.EventID);

                connection.Open();
                connection.Query("AddBetType", p, commandType: CommandType.StoredProcedure);
                connection.Close();
            }
        }

        public void AddCategory(Category category)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@CategoryID", category.CategoryID);
                p.Add("@CategoryName", category.CategoryName);

                connection.Open();
                connection.Query("AddCategory", p, commandType: CommandType.StoredProcedure);
                connection.Close();
            }
        }

        public void AddCompetitor(Competitor competitor)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@CompetitorName", competitor.CompetitorName);
                p.Add("@EventID", competitor.EventID);

                connection.Open();
                connection.Query("AddCompetitor", p, commandType: CommandType.StoredProcedure);
                connection.Close();
            }
        }

        public void AddEvent(Event _event)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@EventID", _event.EventID);
                p.Add("@SportID", _event.SportID);
                p.Add("@TournamentID", _event.TournamentID);
                p.Add("@EventDate", _event.EventDate);
                p.Add("@EventStatusInfo", _event.EventStatusInfo);
                p.Add("@NeutralGround", _event.NeutralGround);
                p.Add("@RoundInfo", _event.RoundInfo);

                connection.Open();
                connection.Query("AddEvent", p, commandType: CommandType.StoredProcedure);
                connection.Close();
            }
        }

        public void AddMarket(Markets market)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@MarketOutcome", market.MarketOutcome);
                p.Add("@MarketOdds", market.MarketOdds);
                p.Add("@BetType", market.BetType);

                connection.Open();
                connection.Query("AddMarkets", p, commandType: CommandType.StoredProcedure);
                connection.Close();
            }
        }

        public void AddSport(Sport sport)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@SportID", sport.SportID);
                p.Add("@SportName", sport.SportName);

                connection.Open();
                connection.Query<Sport>("AddSport", p, commandType: CommandType.StoredProcedure);
                connection.Close();
            }
        }

        public void AddTournament(Tournament tournament)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@TournamentID", tournament.TournamentID);
                p.Add("@TournamentName", tournament.TournamentName);
                p.Add("@SportID", tournament.SportID);
                p.Add("@CategoryID", tournament.CategoryID);

                connection.Open();
                connection.Query("AddTournament", p, commandType: CommandType.StoredProcedure);
                connection.Close();
            }
        }
    }
}
