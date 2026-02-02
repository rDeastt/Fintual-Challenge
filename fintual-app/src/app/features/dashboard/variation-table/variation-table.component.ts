import { Component, input} from '@angular/core';
import { MonthlyVariation } from '../../../core/models/monthly-variation.model';
import { DecimalPipe } from '@angular/common';

@Component({
  selector: 'app-variation-table',
  imports: [DecimalPipe],
  templateUrl: './variation-table.component.html',
})
export class VariationTable {

  data = input.required<MonthlyVariation[]>();
}
