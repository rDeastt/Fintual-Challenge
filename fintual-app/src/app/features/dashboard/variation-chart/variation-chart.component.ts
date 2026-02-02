import {
  Component,
  Input,
  OnChanges,
  SimpleChanges,
  ElementRef,
  ViewChild
} from '@angular/core';
import { CommonModule } from '@angular/common';
import Chart from 'chart.js/auto';
import { MonthlyVariation } from '../../../core/models/monthly-variation.model';

@Component({
  selector: 'app-variation-chart',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './variation-chart.component.html'
})
export class VariationChartComponent implements OnChanges {

  @Input({ required: true })
  data!: MonthlyVariation[];

  @ViewChild('chartCanvas', { static: true })
  canvas!: ElementRef<HTMLCanvasElement>;

  private chart?: Chart;

  ngOnChanges(changes: SimpleChanges): void {
    if (changes['data']) {
      this.renderChart();
    }
  }

  private renderChart() {
    const labels = this.data.map(d => d.month);
    const values = this.data.map(d => d.variation);

    if (this.chart) {
      this.chart.destroy();
    }

    this.chart = new Chart(this.canvas.nativeElement, {
      type: 'line',
      data: {
        labels,
        datasets: [
          {
            label: 'Variación mensual (%)',
            data: values,
            borderWidth: 2,
            tension: 0.3
          }
        ]
      },
      options: {
        responsive: true,
        plugins: {
          legend: { display: true }
        },
        scales: {
          y: {
            ticks: {
              callback: value => `${value}%`
            }
          }
        }
      }
    });
  }
}
