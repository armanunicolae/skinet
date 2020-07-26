import { IProduct } from './product';

export interface IPaginationProduct {
  pageIndex: number;
  pageSize: number;
  count: number;
  data: IProduct[];
}
