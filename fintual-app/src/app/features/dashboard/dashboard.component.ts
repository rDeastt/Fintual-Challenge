import { Component, signal, inject } from '@angular/core';
import { FintualApiService } from '../../core/services/fintual-api.service';
import { MonthlyVariation } from '../../core/models/monthly-variation.model';
import { FUNDS } from '../../core/constants/funds.constant';
import { VariationChartComponent } from "./variation-chart/variation-chart.component";
import { VariationTable } from "./variation-table/variation-table.component";

@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [VariationChartComponent, VariationTable],
  templateUrl: './dashboard.component.html'
})
export class DashboardComponent {

  private api = inject(FintualApiService);

  funds = FUNDS;

  selectedFund = signal<number>(186);
  fromDate = signal('2018-02-12');
  toDate = signal('2026-02-02');

  data = signal<MonthlyVariation[]>([]);
  loading = signal(false);
  error = signal<string | null>(null);

  loadData() {
    this.loading.set(true);
    this.error.set(null);

    this.api.getMonthlyVariation(
      this.selectedFund(),
      this.fromDate(),
      this.toDate()
    ).subscribe({
      next: res => this.data.set(res),
      error: () => {
        this.error.set('Error al cargar datos')
        this.loading.set(false)
        this.data.set([])
      },
      complete: () => this.loading.set(false)
    });
  }
}
