import { createRouter, createWebHistory } from 'vue-router'
import ContactComponent from '../components/ContactComponent.vue'
import ContractComponent from '../components/ContractComponent.veu'

const routes = [
  {
    path: '/Contact', component: ContactComponent,
    path: '/Contract', component: ContractComponent
  }
]

export default createRouter({
  history: createWebHistory(),
  routes
})
