import { inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { MonthlyVariation } from '../models/monthly-variation.model';
import { environment } from '../../../environments/environment';

@Injectable({ providedIn: 'root' })
export class FintualApiService {

  private http = inject(HttpClient);
  private baseUrl = environment.apiUrl;

  getMonthlyVariation(
    fundId: number,
    from: string,
    to: string
  ) {
    return this.http.get<MonthlyVariation[]>(
      `${this.baseUrl}/funds/monthly-variation`,
      {
        params: { fundId, from, to }
      }
    );
  }
}
