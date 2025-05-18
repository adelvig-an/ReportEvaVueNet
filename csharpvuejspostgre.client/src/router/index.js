import { createRouter, createWebHistory } from 'vue-router'
import ReportComponent from '../components/ReportComponent.vue'

const routes = [
  { path: '/reports', component: ReportComponent }
]

export default createRouter({
  history: createWebHistory(),
  routes
})
