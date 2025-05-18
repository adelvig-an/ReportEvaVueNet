<template>
  <div>
    <h2>—писок отчетов</h2>
    <ul>
      <li v-for="report in reports" :key="report.id">
        {{ report.number }} Ч {{ report.reportType }} Ч {{ report.createOn }}
      </li>
    </ul>
  </div>
</template>

<script setup>
import { ref, onMounted } from 'vue'

const reports = ref([])

onMounted(async () => {
  const response = await fetch('/report')
  if (response.ok) {
    reports.value = await response.json()
  }
})
</script>