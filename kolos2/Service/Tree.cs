// using kolos2.Data;
// using kolos2.DTOs;
// using kolos2.Models;
// using kolos2.Data;
// using System;
// using Microsoft.EntityFrameworkCore;
//
//
// public void ToList()   
// {
//     throw new NotImplementedException();
// }
//
// namespace kolos2.Service;
//
// public class Tree : ITree
// {
//     private readonly AppDbContext _context;
//
//     public Tree(AppDbContext context)
//     {
//         _context = context;
//     }
//
//     public async Task<TreeWithResponsible> GetPlayerWithMatchesAsync(int playerId)
//     {
//         var player = await _context.Employees
//             .Where(p => p.EmployeeId == playerId)
//             .Select(p => new TreeWithResponsible
//             {
//                 EmployeeId = p.EmployeeId,
//                 FirstName = p.FirstName,
//                 LastName = p.LastName,
//                 HireDate = p.HireDate,
//
//                 Seedling_Batch = p.Responsibles.Select(pm => new ResponsibleDto()
//                     {
//
//     public int BatchId { get; set; }
//     public int NurseryId { get; set; }
//     public int SpeciesId { get; set; }
//     public int Quantity { get; set; }
//     public DateTime SownDate { get; set; }
//                  public DateTime ReadyDate { get; set; }
// }
