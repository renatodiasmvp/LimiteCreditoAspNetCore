using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LimiteCreditoAspNetCore.Models;

namespace LimiteCreditoAspNetCore.Controllers
{
    public class LIMITES_CREDITO_LICController : Controller
    {
        private readonly ContextoDeDados _context;

        public LIMITES_CREDITO_LICController(ContextoDeDados context)
        {
            _context = context;
        }

        // GET: LIMITES_CREDITO_LIC
        public async Task<IActionResult> Index()
        {
            return View(await _context.lIMITES_CREDITO_LIC.ToListAsync());
        }

        // GET: LIMITES_CREDITO_LIC/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lIMITES_CREDITO_LIC = await _context.lIMITES_CREDITO_LIC
                .FirstOrDefaultAsync(m => m.IDE_LIMITE_CREDITO == id);
            if (lIMITES_CREDITO_LIC == null)
            {
                return NotFound();
            }

            return View(lIMITES_CREDITO_LIC);
        }

        // GET: LIMITES_CREDITO_LIC/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LIMITES_CREDITO_LIC/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDE_LIMITE_CREDITO,IDE_CONTRATO_TERCEIRO,DAT_EXPIRA_LIMITE,DES_OBSERVACAO,QTD_PARCELAS_APROVACAO,VLR_TOTAL_APROVACAO,PER_TAXA_OPERACAO,VLR_TARIFA_OPERACAO,VLR_TOTAL_DESCONTOS,VLR_LIQUIDO_APROVACAO,NUM_PARCELA_INICIAL,IDE_MOTIVO,LIS_SITUACAO,NOM_LOGIN_APROVACAO,DAT_APROVACAO,DES_APROVACAO,STS_LIMITE,DAT_INCLUSAO,NOM_LOGIN_INCLUSAO,NUM_IP_INCLUSAO,DAT_ALTERACAO,NOM_LOGIN_ALTERACAO")] LIMITES_CREDITO_LIC lIMITES_CREDITO_LIC)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lIMITES_CREDITO_LIC);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lIMITES_CREDITO_LIC);
        }

        // GET: LIMITES_CREDITO_LIC/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lIMITES_CREDITO_LIC = await _context.lIMITES_CREDITO_LIC.FindAsync(id);
            if (lIMITES_CREDITO_LIC == null)
            {
                return NotFound();
            }
            return View(lIMITES_CREDITO_LIC);
        }

        // POST: LIMITES_CREDITO_LIC/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDE_LIMITE_CREDITO,IDE_CONTRATO_TERCEIRO,DAT_EXPIRA_LIMITE,DES_OBSERVACAO,QTD_PARCELAS_APROVACAO,VLR_TOTAL_APROVACAO,PER_TAXA_OPERACAO,VLR_TARIFA_OPERACAO,VLR_TOTAL_DESCONTOS,VLR_LIQUIDO_APROVACAO,NUM_PARCELA_INICIAL,IDE_MOTIVO,LIS_SITUACAO,NOM_LOGIN_APROVACAO,DAT_APROVACAO,DES_APROVACAO,STS_LIMITE,DAT_INCLUSAO,NOM_LOGIN_INCLUSAO,NUM_IP_INCLUSAO,DAT_ALTERACAO,NOM_LOGIN_ALTERACAO")] LIMITES_CREDITO_LIC lIMITES_CREDITO_LIC)
        {
            if (id != lIMITES_CREDITO_LIC.IDE_LIMITE_CREDITO)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lIMITES_CREDITO_LIC);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LIMITES_CREDITO_LICExists(lIMITES_CREDITO_LIC.IDE_LIMITE_CREDITO))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(lIMITES_CREDITO_LIC);
        }

        // GET: LIMITES_CREDITO_LIC/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lIMITES_CREDITO_LIC = await _context.lIMITES_CREDITO_LIC
                .FirstOrDefaultAsync(m => m.IDE_LIMITE_CREDITO == id);
            if (lIMITES_CREDITO_LIC == null)
            {
                return NotFound();
            }

            return View(lIMITES_CREDITO_LIC);
        }

        // POST: LIMITES_CREDITO_LIC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lIMITES_CREDITO_LIC = await _context.lIMITES_CREDITO_LIC.FindAsync(id);
            _context.lIMITES_CREDITO_LIC.Remove(lIMITES_CREDITO_LIC);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LIMITES_CREDITO_LICExists(int id)
        {
            return _context.lIMITES_CREDITO_LIC.Any(e => e.IDE_LIMITE_CREDITO == id);
        }
    }
}
